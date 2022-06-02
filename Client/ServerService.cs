using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;


namespace Client
{
    class ServerService
    {
        string serverLink;
        string token = "";
        string nick = "";
        int maxId = 0;

        public ServerService()
        {
            this.serverLink = Properties.Settings.Default.server_link;
            token = "";
            nick = "";
            maxId = 0;
        }

        public Person registration(Person person)
        {    
            string url = serverLink;
            nick = person.getNickname();

            Task<dynamic> DynamicResult = url.AppendPathSegment("/auth/registration").PostJsonAsync(
                new { login = person.getLogin(), password = person.getPassword(), nickname = person.getNickname() }).ReceiveJson();

            bool error = false;

            try
            {
                token = DynamicResult.Result.result.access;
            }
            catch
            {
                error = true;
            }
            

            if (error)
                throw new Exception("Current user already exists");

            
            

            
            return person;  
        }

        public Person login(Person person)
        {
            string url = serverLink;
            Task<dynamic> DynamicResult = url.AppendPathSegment("/auth/login").PostJsonAsync(
                 new { login = person.getLogin(), password = person.getPassword(), nickname = person.getNickname() }).ReceiveJson();


            bool error = false;
            nick = person.getNickname();


            try
            {
                token = DynamicResult.Result.result.access;
                
            }
            catch
            {
                error = true;
            }


            if (error)
                throw new Exception("Current user already exists");

            return person;
        }

        public Person[] getUsers()
        {
            string url = serverLink;
            Task<dynamic> DynamicResult = url.AppendPathSegment("/auth/getUsers").GetJsonAsync();

            bool error = false;
            List<Person> people = new List<Person>();
            //int length = getLength(DynamicResult);
            try
            {
                foreach(dynamic obj in DynamicResult.Result.result)
                {
                    people.Add(new Person(obj.password,
                        obj.nickname,
                        obj.login));

                }
            }
            catch
            {
                error = true;
            }

            if (error)
                throw new Exception("Something went wrong");

            return people.ToArray();
        }

        
        public string postMessage(string text)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Bearer ");
            stringBuilder.Append(token);

            string url = serverLink;
            Task<dynamic> DynamicResult = url.AppendPathSegment("/chat/postMessage").WithHeader("Authorization", stringBuilder.ToString()).PostJsonAsync(
                new { message = text, nickname = nick }).ReceiveJson();

            try
            {
               maxId = (int)DynamicResult.Result.result.id;
            }
            catch
            {
                throw new Exception("Something went wrong");
            }

            
            StringBuilder builder= new StringBuilder();
            builder.Append(nick);
            builder.Append(" : ");
            builder.Append(text);

            return builder.ToString();
        }

        public string getMessages()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Bearer ");
            stringBuilder.Append(token);

            string url = serverLink;
            int amount = 0;

            Task<dynamic> DynamicResult = url.AppendPathSegment("/chat/getAmount").WithHeader("Authorization", stringBuilder.ToString()).GetJsonAsync();
            try
            {
                amount = (int)DynamicResult.Result.result;

                Task<dynamic> DynamicResult2 = url.
                    AppendPathSegment("/chat/getChat")
                    .WithHeader("Authorization", stringBuilder.ToString())
                    .PostJsonAsync(new { amount = (amount-maxId) }).ReceiveJson();



                StringBuilder builder = new StringBuilder();
                for(int  i = 0;i < (amount - maxId); i++)
                {
                    builder.Append((string)DynamicResult2.Result.result[i].nickname);

                    builder.Append(" : ");

                    builder.Append((string)DynamicResult2.Result.result[i].message);

                    builder.Append("\n");
                }
                

                return builder.ToString();

            }
            catch(Exception err)
            {
                throw new Exception("Something went wrong");
            }
        }

        public Message[] GetMessages()
        {
            string url = serverLink;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Bearer ");
            stringBuilder.Append(token);

            Task<dynamic> DynamicResult = url
                .AppendPathSegment("chat/getAllMessages")
                .WithHeader("Authorization", stringBuilder.ToString())
                .GetJsonAsync();


            List<Message> messages = new List<Message>();
            foreach (dynamic obj in DynamicResult.Result.result)
            {
                messages.Add(new Message(obj.message, obj.nickname));

            }


            return messages.ToArray();

        }

        
    }
}
