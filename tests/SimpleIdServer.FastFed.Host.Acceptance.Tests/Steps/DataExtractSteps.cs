﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using BlushingPenguin.JsonPath;
using Microsoft.AspNetCore.WebUtilities;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Web;
using TechTalk.SpecFlow;

namespace SimpleIdServer.FastFed.Host.Acceptance.Tests;

[Binding]
public class DataExtractSteps
{
    private readonly ScenarioContext _scenarioContext;

    public DataExtractSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [When("extract JSON from body")]
    public async Task WhenExtractFromBody()
    {
        var httpResponseMessage = _scenarioContext["httpResponseMessage"] as HttpResponseMessage;
        var json = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
        _scenarioContext.Set(JsonDocument.Parse(json), "jsonHttpBody");
    }

    [When("extract query parameters into JSON")]
    public void WhenExtractQueryParametersIntoJSON()
    {
        var httpResponseMessage = _scenarioContext["httpResponseMessage"] as HttpResponseMessage;
        var queryValues = QueryHelpers.ParseQuery(httpResponseMessage.RequestMessage.RequestUri.Query);
        var jObj = new JsonObject();
        foreach (var kvp in queryValues)
        {
            jObj.Add(kvp.Key, queryValues[kvp.Key][0]);
        }

        _scenarioContext.Set(jObj, "jsonHttpBody");
    }

    [When("extract query parameter '(.*)' into JSON")]
    public void WhenExtractQueryParameterIntoJSON(string name)
    {
        var httpResponseMessage = _scenarioContext["httpResponseMessage"] as HttpResponseMessage;
        var queryValues = QueryHelpers.ParseQuery(httpResponseMessage.RequestMessage.RequestUri.Query);
        var value = queryValues[name][0].ToString();
        value = HttpUtility.UrlDecode(value);
        var jObj = JsonDocument.Parse(value);
        _scenarioContext.Set(jObj, "jsonHttpBody");
    }

    [When("extract parameter '(.*)' from redirect url")]
    public void WhenExtractRedirectUrlParameter(string parameter)
    {
        var httpResponseMessage = _scenarioContext["httpResponseMessage"] as HttpResponseMessage;
        var queries = QueryHelpers.ParseQuery(httpResponseMessage.RequestMessage.RequestUri.Query);
        var queryValue = queries[parameter][0];
        _scenarioContext.Set(queryValue, parameter);
    }

    [When("extract parameter '(.*)' from redirect url fragment")]
    public void WhenExtractRedirectUrlFragmentParameter(string parameter)
    {
        var httpResponseMessage = _scenarioContext["httpResponseMessage"] as HttpResponseMessage;
        var queries = QueryHelpers.ParseQuery(httpResponseMessage.RequestMessage.RequestUri.Fragment.TrimStart('#'));
        var queryValue = queries[parameter][0];
        _scenarioContext.Set(queryValue, parameter);
    }

    [When("extract parameter '(.*)' from JSON body")]
    public void WhenExtractParameterFromBody(string parameter)
    {
        var jObj = _scenarioContext.Get<JsonDocument>("jsonHttpBody");
        var token = jObj.SelectToken(parameter);
        _scenarioContext.Set(token.Value.GetString(), parameter);
    }

    [When("extract parameter '(.*)' from JSON body into '(.*)'")]
    public void WhenExtractParameterFromBody(string parameter, string key)
    {
        var jObj = _scenarioContext.Get<JsonDocument>("jsonHttpBody");
        _scenarioContext.Set(jObj.SelectToken(parameter).Value.GetString(), key);
    }
}
