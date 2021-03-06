﻿using Org.Reddragonit.BpmEngine.Attributes;
using Org.Reddragonit.BpmEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Org.Reddragonit.BpmEngine.Elements.Processes.Gateways
{
    [XMLTag("bpmn","parallelGateway")]
    internal class ParallelGateway : AGateway
    {
        public ParallelGateway(XmlElement elem, XmlPrefixMap map, AElement parent)
            : base(elem, map, parent) { }

        public override string[] EvaulateOutgoingPaths(Definition definition, IsFlowValid isFlowValid, ProcessVariablesContainer variables)
        {
            return Outgoing;
        }

        public override bool IsIncomingFlowComplete(string incomingID, ProcessPath path)
        {
            bool ret = true;
            foreach (string str in Incoming)
            {
                if (path.GetStatus(str)!=StepStatuses.Succeeded)
                {
                    ret = false;
                    break;
                }
            }
            return ret;
        }
    }
}
