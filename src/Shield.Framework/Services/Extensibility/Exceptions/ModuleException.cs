﻿using System;
using System.Runtime.Serialization;

namespace Shield.Framework.Services.Extensibility.Exceptions
{
    [Serializable]
    public class ModuleException : Exception
    {
        public string ModuleName { get; set; }

        public ModuleException()
            : this(null)
        {
        }

        public ModuleException(string message)
            : this(null, message)
        {
        }

        public ModuleException(string message, Exception innerException)
            : this(null, message, innerException)
        {
        }

        public ModuleException(string moduleName, string message)
            : this(moduleName, message, null)
        {
        }

        public ModuleException(string moduleName, string message, Exception innerException)
            : base(message, innerException)
        {
            ModuleName = moduleName;
        }

        protected ModuleException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
