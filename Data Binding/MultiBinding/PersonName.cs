// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MultiBinding
{
    public class PersonName
    {
        public PersonName(string first, string last)
        {
            a = "Mr.";
            FirstName = first;
            LastName = last;
        }
        public string a { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}