#region License

/*
 * Copyright � 2002-2011 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

using System;
using System.Data;
using System.Configuration;

namespace Spring.Bsn
{
    /// <summary>
    /// <see cref="IConversationEvidenceBsn"/>
    /// </summary>
    public class ConversationEvidenceBsnImpl: IConversationEvidenceBsn
    {
        private String uniqueId = "";

        /// <summary>
        /// Create instance with unique id.
        /// </summary>
        public ConversationEvidenceBsnImpl()
        {
            uniqueId = Guid.NewGuid().ToString();
        }

        #region IConversationEvidenceBsn Members

        /// <summary>
        /// <see cref="IConversationEvidenceBsn"/>
        /// </summary>
        /// <returns></returns>
        public String UniqueId()
        {
            return this.uniqueId;
        }

        #endregion
    }
}
