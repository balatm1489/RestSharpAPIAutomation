using System.Configuration;


namespace ReqresAPI.Tests.Utilities
{
    public class BrowseAPIURL
    {
        /// Initialize base reqres login Url.
        /// </summary>
        private readonly string _baseUrl;

        // Property of URL
        public string GetURL
        {
            get { return this._baseUrl; }
        }

        /// <summary>
        /// Gets the base API Url from configuration.
        /// </summary>
        /// <param name="apiType">This is API Type</param>
        public BrowseAPIURL(string apiType, string parameter1 = "", string parameter2 = "", string
            parameter3 = "", string parameter4 = "", string parameter5 = "", string parameter6 = "", string parameter7 = "")
        {
            try
            {
                switch (apiType)
                {
                    // Get API base URL
                    case "ReqresAPIGetListUsers":
                        _baseUrl = string.Format("https://reqres.in/api/users?page={0}", parameter1);
                        break;


                    case "ReqresAPIPOSTCreateUser":
                        _baseUrl = string.Format("https://reqres.in/api/users");
                        break;
                    case "ReqresAPIGetSingleUser":
                    case "ReqresAPIPUTUpdateSingleUser":
                    case "ReqresAPIPATCHUpdateSingleUser":
                        _baseUrl = string.Format("https://reqres.in/api/users/{0}", parameter1);
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}