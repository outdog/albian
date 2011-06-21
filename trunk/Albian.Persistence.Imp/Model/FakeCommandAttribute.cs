﻿using System.Data.Common;
using Albian.Persistence.Model;

namespace Albian.Persistence.Imp.Model
{
    public class FakeCommandAttribute : IFakeCommandAttribute
    {
        private string _commandText = string.Empty;
        private string _storageName = string.Empty;

        #region IFakeCommandAttribute Members

        public string StorageName
        {
            get { return _storageName; }
            set { _storageName = value; }
        }

        public string CommandText
        {
            get { return _commandText; }
            set { _commandText = value; }
        }

        public DbParameter[] Paras { get; set; }

        #endregion
    }
}