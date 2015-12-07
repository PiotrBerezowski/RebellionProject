using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RebellionWcfHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRebellionDatabase" in both code and config file together.
    [ServiceContract]
    public interface IRebellionDatabase
    {
        [OperationContract]
        Dictionary<int, string> ViewGroupDatabase();

        [OperationContract]
        void CreateNewGroup(string GroupName, int GroupID, string Territory);

        [OperationContract]
        void CreateNewMission(string MissionName, int MissionID, string Type, int GroupID);

        [OperationContract]
        void createNewRebel(string Codename, int RebelID, int GroupID);

        [OperationContract]
        string DeleteRebel(int id);

        [OperationContract]
        string FindGroup(int id);

        [OperationContract]
        string FindMission(int id);

        [OperationContract]
        string FindRebel(int id);

        [OperationContract]
        void UpdateAGroup(string GroupName, int GroupID, string Territory);

        [OperationContract]
        void UpdateAMission(string MissionName, int MissionID, string Type, int GroupID);

        [OperationContract]
        void UpdateARebel(string NewName, int ID, int GroupID);
        
    }
}
