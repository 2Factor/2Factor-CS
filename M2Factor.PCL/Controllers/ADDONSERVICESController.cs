/*
 * M2Factor.PCL
 *
 * This file was automatically generated for 2Factor by APIMATIC BETA v2.0 on 02/18/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMATIC.SDK.Common;
using APIMATIC.SDK.Http.Request;
using APIMATIC.SDK.Http.Response;
using APIMATIC.SDK.Http.Client;
using SolvTech.Models;

namespace SolvTech.Controllers
{
    public partial class ADDONSERVICESController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ADDONSERVICESController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ADDONSERVICESController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ADDONSERVICESController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Check Balance For Addon Services
        /// </summary>
        /// <param name="apiKey">Required parameter: 2Factor account API Key</param>
        /// <param name="serviceName">Required parameter: Name of the addon service</param>
        /// <return>Returns the CheckBalanceAddonServicesModel response from the API call</return>
        public async Task<CheckBalanceAddonServicesModel> GetCheckBalanceAddonServicesAsync(
                string apiKey,
                string serviceName)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/V1/{api_key}/ADDON_SERVICES/BAL/{service_name}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "api_key", apiKey },
                { "service_name", serviceName }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "2Factor" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<CheckBalanceAddonServicesModel>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Pull Delivery Report - Transactional SMS
        /// </summary>
        /// <param name="apiKey">Required parameter: API Obtained From 2Factor.in</param>
        /// <param name="sessionId">Required parameter: Session Id Returned By Send SMS Step</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetPullDeliveryReportAsync(
                string apiKey,
                string sessionId)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/V1/{api_key}/ADDON_SERVICES/RPT/TSMS/{session_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "api_key", apiKey },
                { "session_id", sessionId }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "2Factor" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Send Single / Bulk Transactional Messages / Schedule SMS
        /// </summary>
        /// <param name="apiKey">Required parameter: API Obtained From 2Factor.in</param>
        /// <param name="mfrom">Required parameter: 6 Character Alphabet Sender Id</param>
        /// <param name="msg">Required parameter: SMS Body To Be Sent</param>
        /// <param name="to">Required parameter: Comma Separated list Of Phone Numbers</param>
        /// <param name="sendAt">Optional parameter: This Parameter Is Used For Scheduling SMS - Optional parameter</param>
        /// <param name="fieldParameters">Additional optional form parameters are supported by this endpoint</param>
        /// <return>Returns the SendTransactionalSmsModel response from the API call</return>
        public async Task<SendTransactionalSmsModel> CreateSendTransactionalSMSAsync(
                string apiKey,
                string mfrom,
                string msg,
                string to,
                string sendAt = null,
                Dictionary<string, object> fieldParameters = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/V1/{api_key}/ADDON_SERVICES/SEND/TSMS");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "api_key", apiKey }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "2Factor" },
                { "accept", "application/json" }
            };

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "From", mfrom },
                { "Msg", msg },
                { "To", to },
                { "SendAt", (null != sendAt) ? sendAt : "2019-01-01 00:00:01" }
            };
            //optional form parameters
            _fields.Add(APIHelper.PrepareFormFieldsFromObject("",fieldParameters));

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<SendTransactionalSmsModel>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

    }
} 