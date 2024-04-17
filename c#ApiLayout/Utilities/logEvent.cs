using MongoDB.Bson;
using MongoDB.Driver;

namespace c_ApiLayout.Utilities
{
    public class Log
    {
        public static void LogEvent(IMongoCollection<BsonDocument> logCollection, string username, string password)
        {
            List<UserDto> bruker = new List<UserDto>
    {
    new UserDto { username = "emkra", password = "123" },
    new UserDto { username = "ekte", password = "789" },
    new UserDto { username = "kaste", password = "456" }
    };

            foreach (var i in bruker)
            {
                string usernameVal = username;
                string passwordVal = password;
                if (i.username == usernameVal)
                {
                    if (i.password == passwordVal)
                    {
                        var log = new BsonDocument
        {
                {"username men kulere", username },
                {"password", password }
        };
                        logCollection.InsertOne(log);
                    }
                }
                   
                else
                { 
                }
;
            }
        }

            

        }
    }
