﻿using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using mRemoteNG.Credential;
using mRemoteNG.Credential.Repositories;

namespace mRemoteNG.Config.Serializers.CredentialProviderSerializer
{
    public class CredentialRepositoryListDeserializer
    {
        public IEnumerable<ICredentialRepository> Deserialize(string xml)
        {
            var xdoc = XDocument.Parse(xml);
            var repoEntries = xdoc.Descendants("CredentialRepository");
            return repoEntries.Select(CredentialRepositoryFactory.Build);
        }
    }
}