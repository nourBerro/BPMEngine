﻿using Org.Reddragonit.BpmEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml;

namespace Org.Reddragonit.BpmEngine
{
    #region Ons
    public delegate void OnEventStarted(IElement Event, ReadOnlyProcessVariablesContainer variables);
    public delegate void OnEventCompleted(IElement Event, ReadOnlyProcessVariablesContainer variables);
    public delegate void OnEventError(IElement Event, ReadOnlyProcessVariablesContainer variables);
    public delegate void OnTaskStarted(IElement task, ReadOnlyProcessVariablesContainer variables);
    public delegate void OnTaskCompleted(IElement task, ReadOnlyProcessVariablesContainer variables);
    public delegate void OnTaskError(IElement task, ReadOnlyProcessVariablesContainer variables);
    public delegate void OnProcessStarted(IElement process, ReadOnlyProcessVariablesContainer variables);
    public delegate void OnProcessCompleted(IElement process, ReadOnlyProcessVariablesContainer variables);
    public delegate void OnProcessError(IElement process, ReadOnlyProcessVariablesContainer variables);
    public delegate void OnSequenceFlowCompleted(IElement flow, ReadOnlyProcessVariablesContainer variables);
    public delegate void OnMessageFlowCompleted(IElement flow, ReadOnlyProcessVariablesContainer variables);
    public delegate void OnGatewayStarted(IElement gateway, ReadOnlyProcessVariablesContainer variables);
    public delegate void OnGatewayCompleted(IElement gateway, ReadOnlyProcessVariablesContainer variables);
    public delegate void OnGatewayError(IElement gateway, ReadOnlyProcessVariablesContainer variables);
    public delegate void OnStateChange(XmlDocument stateDocument);
    internal delegate void processStateChanged();
    #endregion

    #region Validations
    public delegate bool IsEventStartValid(IElement Event, ProcessVariablesContainer variables);
    public delegate bool IsProcessStartValid(IElement process, ProcessVariablesContainer variables);
    #endregion

    #region Conditions
    public delegate bool IsFlowValid(IElement flow, ProcessVariablesContainer variables);
    #endregion

    #region Tasks
    public delegate void ProcessBusinessRuleTask(IElement task, ref ProcessVariablesContainer variables);
    public delegate void CompleteManualTask(string taskID, ProcessVariablesContainer newVariables);
    public delegate void ErrorManualTask(string taskID, Exception ex);
    public delegate void BeginManualTask(IElement task, ProcessVariablesContainer variables, CompleteManualTask completeCallback, ErrorManualTask errorCallBack);
    public delegate void ProcessRecieveTask(IElement task, ref ProcessVariablesContainer variables);
    public delegate void ProcessScriptTask(IElement task, ref ProcessVariablesContainer variables);
    public delegate void ProcessSendTask(IElement task, ref ProcessVariablesContainer variables);
    public delegate void ProcessServiceTask(IElement task, ref ProcessVariablesContainer variables);
    public delegate void ProcessTask(IElement task, ref ProcessVariablesContainer variables);
    public delegate void CompleteUserTask(string taskID, ProcessVariablesContainer newVariables,string completedByID);
    public delegate void ErrorUserTask(string taskID, Exception ex);
    public delegate void BeginUserTask(IElement task, ProcessVariablesContainer variables, IElement lane, CompleteUserTask completeCallback, ErrorUserTask errorCallBack);
    #endregion

    #region internals
    internal delegate void ProcessStepComplete(string sourceID,string outgoingID);
    internal delegate void ProcessStepError(IElement step);
    #endregion

    #region Logging
    public delegate void LogLine(AssemblyName assembly, string fileName, int lineNumber, LogLevels level, DateTime timestamp, string message);
    public delegate void LogException(AssemblyName assembly, string fileName, int lineNumber, DateTime timestamp, Exception exception);
    #endregion
}
