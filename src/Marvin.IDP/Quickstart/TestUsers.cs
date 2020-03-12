// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace Marvin.IDP
{
    public class TestUsers
    {
        public static List<TestUser> Users = new List<TestUser>
        {
            new TestUser
            {
                SubjectId = "D69A2C79-CBC6-474F-B50D-A964B6B45544",
                Username = "Frank",
                Password = "password",

                Claims = new List<Claim>
                {
                    new Claim("given_name", "Frank"),
                    new Claim("family_name", "Underwood")
                }
            },
            new TestUser
            {
                SubjectId = "DF2195FE-AF86-42F4-A330-28D0C36CC298",
                Username = "Claire",
                Password = "password",

                Claims = new List<Claim>
                {
                    new Claim("given_name", "Claire"),
                    new Claim("family_name", "Underwood")
                }
            }
            //new TestUser{SubjectId = "818727", Username = "alice", Password = "alice", 
            //    Claims = 
            //    {
            //        new Claim(JwtClaimTypes.Name, "Alice Smith"),
            //        new Claim(JwtClaimTypes.GivenName, "Alice"),
            //        new Claim(JwtClaimTypes.FamilyName, "Smith"),
            //        new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
            //        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
            //        new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
            //        new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
            //    }
            //},
            //new TestUser{SubjectId = "88421113", Username = "bob", Password = "bob", 
            //    Claims = 
            //    {
            //        new Claim(JwtClaimTypes.Name, "Bob Smith"),
            //        new Claim(JwtClaimTypes.GivenName, "Bob"),
            //        new Claim(JwtClaimTypes.FamilyName, "Smith"),
            //        new Claim(JwtClaimTypes.Email, "BobSmith@email.com"),
            //        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
            //        new Claim(JwtClaimTypes.WebSite, "http://bob.com"),
            //        new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json),
            //        new Claim("location", "somewhere")
            //    }
            //}
        };
    }
}