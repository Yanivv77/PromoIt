
namespace UI
{
   
    class ApiAccessor
    {
        private readonly User.UserClient _client = new User.UserClient(new HttpClient());
        public async Task<bool> SendAsync(string username, string password)
        {
            try
            {
                await _client.SendAsync(new User.User{ UserName = username, Password = password });
                return true;
            }
            catch (Exception)
            {
                //todo: log
                return false;
            }
        }

       

        public async Task<List<string>> SendAsyncUser(string username, string password)
        {
            List<string> user = new List<string>();
            string name = new User.User { UserName = username, Password = password }.UserName;
            string pass = new User.User { UserName = username, Password = password }.Password;
            user.Add(name);
            user.Add(pass);


            //await _client.SendAsync(new User.User { UserName = username, Password = password });

            return user;

        }



    }
}