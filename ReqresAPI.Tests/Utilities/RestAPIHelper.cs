﻿using ReqresAPI.Tests.APIModules.ReqresAPIService.Request;
using RestSharp.Authenticators;
using RestSharp;
using System.Net;


namespace ReqresAPI.Tests.Utilities
{

    public static class RestAPIHelper
    {
        public static RestClient? client;
        public static RestRequest? restRequest;

        #region Set URL

        /// <summary>
        /// Set URL
        /// </summary>
        /// <param name="endPoint">This is rest endpoint.</param>
        /// <returns></returns>
        public static RestClient SetUrl(string endPoint)
        {
            client = new RestClient(endPoint);
            return client;
        }

        #endregion Set URL

        #region GET Request

        /// <summary>
        /// Creating the get request
        /// </summary>
        /// <returns>restRequest</returns>
        public static RestRequest GETRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddHeader("Method", "GET");
            restRequest.AddHeader("ContentType", "application/json");
            return restRequest;
        }
        #endregion GET Request

        #region GET Response

        /// <summary>
        /// Get response
        /// </summary>
        /// <returns></returns>
        public static IRestResponse GetResponse()
        {
            client.Authenticator = new NtlmAuthenticator();
            return client.Execute(restRequest);
        }

        /// <summary>
        /// Get Response by enforcing TLS 1.2 on Targetprocess side
        /// </summary>
        /// <returns>IRestResponse</returns>
        public static IRestResponse GetResponseTLSTargetprocess()
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.ServicePointManager.SecurityProtocol | System.Net.SecurityProtocolType.Tls12;
            return client.Execute(restRequest);
        }
        #endregion GET Response

        #region POST Request

        /// <summary>
        /// Rest request for creating the users
        /// </summary>
        /// <param name="_property">This is property object of user</param>

        /// <returns>Rest Request</returns>
        public static RestRequest ReqresAPICreateUserPostRequest(ReqresApipostCreateUserRequestProperties _property)
        {
            restRequest = new RestRequest(Method.POST);
            restRequest.AddJsonBody(_property);
            return restRequest;
        }

        #endregion POST Request

        #region GET Response status code

        /// <summary>
        /// Get response status code
        /// </summary>
        /// <param name="response">rest response.</param>
        /// <returns>numericStatusCode</returns>
        public static int GetResponseStatusCode(IRestResponse response)
        {
            int numericStatusCode = 0;
            // Get the responce status code
            HttpStatusCode statusCode = response.StatusCode;
            return numericStatusCode = (int)statusCode;
        }

        #endregion GET Response status code

        #region PUT Request

        /// <summary>
        /// Rest request for updating the Single users details using put
        /// </summary>
        /// <param name="_property">This is property of user</param>

        /// <returns>Rest Request</returns>
        public static RestRequest ReqresAPIPUTSingleUsePostRequest(ReqresApipostCreateUserRequestProperties _property)
        {
            //Create Rest request
            restRequest = new RestRequest(Method.PUT);
            restRequest.AddJsonBody(_property);
            return restRequest;
        }

        #endregion PUT Request

        #region PATCH Request
        /// <summary>
        /// Rest request for updating the Single users details using put
        /// </summary>
        /// <param name="_property">This is property of user</param>

        /// <returns>Rest Request</returns>
        public static RestRequest ReqresAPIPATCHSingleUsePostRequest(ReqresApipostCreateUserRequestProperties _property)
        {
            //Create Rest request
            restRequest = new RestRequest(Method.PATCH);
            restRequest.AddJsonBody(_property);
            return restRequest;
        }
        #endregion PATCH Request
    }
}
