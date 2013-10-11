﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NGinnBPM.ProcessModel
{
    /// <summary>
    /// Interface for accessing custom properties of process definition components.
    /// Custom properties can be used by external tools to specify additional information.
    /// </summary>
    public interface IHaveExtensionProperties
    {
        IEnumerable<string> GetExtensionProperties(string ns);
        string GetExtensionProperty(string ns, string name);
        string GetExtensionProperty(string fullName);
        void SetExtensionProperty(string ns, string name, string value);
    }
}
