﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wCyber.Helpers.Identity.Auth;

namespace EmergenceResponse.Data
{
    public class UserExternalLogin : IExternalLogin
    {
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid UserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LoginId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ProviderKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AuthSchemeId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PictureUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
