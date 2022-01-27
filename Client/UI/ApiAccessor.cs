
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

        internal Task SendAsync()
        {
            throw new NotImplementedException();
        }
    }
}