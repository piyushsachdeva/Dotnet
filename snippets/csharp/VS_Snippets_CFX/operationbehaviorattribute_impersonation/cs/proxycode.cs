﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://microsoft.wcf.documentation", ConfigurationName="SampleHello")]
public interface SampleHello
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.wcf.documentation/SampleHello/Hello", ReplyAction="http://microsoft.wcf.documentation/SampleHello/HelloResponse")]
    string Hello(string greeting);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface SampleHelloChannel : SampleHello, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class SampleHelloClient : System.ServiceModel.ClientBase<SampleHello>, SampleHello
{
    
    public SampleHelloClient()
    {
    }
    
    public SampleHelloClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public SampleHelloClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SampleHelloClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SampleHelloClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string Hello(string greeting)
    {
        return base.Channel.Hello(greeting);
    }
}
