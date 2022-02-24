using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BusinessLayerValidation
{
    class Class1 : IDataErrorInfo
    {
        public string Name { get; set; }
        public string this[string age]
        {
            get
            {
                string result = null;

                if (age == "Name")
                {
                    if (Name != "AHM")
                    {
                        result = "이름을 입력해 주세요.";
                    }
                }
                return result;
            }
        }

        public string Error => null;
    }
}
