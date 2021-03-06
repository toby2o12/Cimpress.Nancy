﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cimpress.Nancy.Components;
using Cimpress.Nancy.Config;

namespace Cimpress.Nancy.Security.Demo.Security
{
    public class AuthValidator : OAuth2Validator
    {
        public AuthValidator(INancyLogger log, IConfiguration config) : base(log)
        {
            OAuth2Issuer = config.OptionalParameters["OAuth2Issuer"];
            OAuthSecretKey = config.OptionalParameters["OAuth2SecretKey"];
            OAuth2ClientId = config.OptionalParameters["OAuth2ClientId"];
            OAuth2JwksLocation = config.OptionalParameters["OAuth2JwksLocation"];
            OAuth2JwksAudience = config.OptionalParameters["OAuth2JwksAudience"];
        }

        public override string OAuth2Issuer { get; }
        public override string OAuthSecretKey { get; }
        public override string OAuth2ClientId { get; }
        public override string OAuth2JwksLocation { get; }
        public override string OAuth2JwksAudience { get; }
    }
}
