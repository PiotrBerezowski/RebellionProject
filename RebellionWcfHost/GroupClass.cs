using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RebellionWcfHost
{
    [DataContract]
    public class GroupClass
    {

        private string _groupName;
        private int _groupID;
        private string _territory;

        [DataMember]
        public string groupName
        {
            get { return _groupName; }
            set { _groupName = value; }
        }

        [DataMember]
        public int groupID
        {
            get { return _groupID; }
            set { _groupID = value; }
        }


        [DataMember]
        public string territory
        {
            get { return _territory; }
            set { _territory = value; }
        }


    }
}
