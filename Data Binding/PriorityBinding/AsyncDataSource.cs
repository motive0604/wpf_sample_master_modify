// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Threading;

namespace PriorityBinding
{
    public class AsyncDataSource
    {
        private string _slowerDp;
        private string _slowestDp;
        private string _hallym;
        public string FastDp { get; set; }

        public string SlowerDp
        {
            get
            {
                // This simulates a lengthy time before the
                // data being bound to is actualy available.
                Thread.Sleep(3000);
                return _slowerDp;
            }
            set { _slowerDp = value; }
        }

        public string SlowestDp
        {
            get
            {
                // This simulates a lengthy time before the
                // data being bound to is actualy available.
                Thread.Sleep(5000);
                return _slowestDp;
            }
            set { _slowestDp = value; }
        }
        public string Hallym
        {
            get
            {
                // This simulates a lengthy time before the
                // data being bound to is actualy available.
                Thread.Sleep(7000);
                return _hallym;
            }
            set { _hallym = value; }
        }
    }
}