﻿using FluentAssertions;
using RestSharp;
using TechnicalTest.Service;

namespace TechnicalTest
{
    public class LocationClient
    {
        private readonly RestService _restService;
        private readonly ConfigurationProvider _configurationProvider;
        private RestResponse Response;

        public LocationClient(RestService restService, ConfigurationProvider configurationProvider)
        {
            _restService = restService;
            _configurationProvider = configurationProvider;
        }

        public void GetLocationInformation(string countryCode, string postCode)
        {
            var url = string.Format(_configurationProvider.GetUrl(), countryCode, postCode);
            Response = _restService.Get(url);
        }

        public void VerifyRequestStatus(string isSuccessful)
        {
            Response.IsSuccessStatusCode.ToString().ToLower().Should().Be(isSuccessful.ToLower());
        }
    }
}

