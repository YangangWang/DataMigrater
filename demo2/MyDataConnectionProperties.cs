using Microsoft.Data.ConnectionUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace demo2
{
    public class MyDataConnectionProperties : IDataConnectionProperties
    {
        public object this[string propertyName] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsExtensible => throw new NotImplementedException();

        public bool IsComplete => throw new NotImplementedException();

        public event EventHandler PropertyChanged;

        public void Add(string propertyName)
        {
            throw new NotImplementedException();
        }

        public bool Contains(string propertyName)
        {
            throw new NotImplementedException();
        }

        public void Parse(string s)
        {
            throw new NotImplementedException();
        }

        public void Remove(string propertyName)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Reset(string propertyName)
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }

        public string ToDisplayString()
        {
            throw new NotImplementedException();
        }

        public string ToFullString()
        {
            throw new NotImplementedException();
        }
    }
}
