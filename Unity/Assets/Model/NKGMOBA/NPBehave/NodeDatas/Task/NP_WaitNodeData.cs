//------------------------------------------------------------
// Author: 烟雨迷离半世殇
// Mail: 1778139321@qq.com
// Data: 2019年8月21日 7:13:45
//------------------------------------------------------------

using System.Collections.Generic;
using NPBehave;
using Sirenix.OdinInspector;

namespace ETModel
{
    public class NP_WaitNodeData:NP_NodeDataBase
    {
        [LabelText("等待结点")]
        public Wait mWaitNode;
        
        public override Node GetNPBehaveNode()
        {
            return this.mWaitNode;
        }

        public override void AutoSetNodeData(List<Node>  nextNode)
        {
            throw new System.NotImplementedException();
        }
    }
}