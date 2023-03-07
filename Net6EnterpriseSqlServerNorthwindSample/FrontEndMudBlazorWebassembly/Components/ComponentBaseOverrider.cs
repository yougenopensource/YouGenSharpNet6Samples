/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Diagnostics;
using Newtonsoft.Json;
namespace Northwind_FrontEndMudBlazorWebassembly.Components;
public abstract class ComponentBaseOverrider : ComponentBase
{
    public override Task SetParametersAsync(ParameterView parameters)
    {
#if DEBUG
        Console.WriteLine("SetParametersAsync Parameters Set Async: ");
        Console.WriteLine(JsonConvert.SerializeObject(parameters));
        Debug.WriteLine("SetParametersAsync Parameters Set Async: ");
        Debug.WriteLine(JsonConvert.SerializeObject(parameters));
#endif
        try
        {
            return base.SetParametersAsync(parameters);
        }
        catch (Exception ex)
        {
#if DEBUG
            //log to console
            Console.WriteLine("exception Thrown");
            Console.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            Debug.WriteLine("exception Thrown");
            Debug.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            throw;
#endif
            throw new Exception("Exception: Problem occurred while setting route parameters async event.");
        }
    }
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
#if DEBUG
        Console.WriteLine("BuildRenderTree: ");
        Console.WriteLine(JsonConvert.SerializeObject(builder));
        Debug.WriteLine("BuildRenderTree: ");
        Debug.WriteLine(JsonConvert.SerializeObject(builder));
#endif
        try
        {
            base.BuildRenderTree(builder);
        }
        catch (Exception ex)
        {
#if DEBUG
            //log to console
            Console.WriteLine("exception Thrown");
            Console.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            Debug.WriteLine("exception Thrown");
            Debug.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            throw;
#endif
            throw new Exception("Exception: Problem occurred while building render tree.");
        }
    }
    protected override void OnAfterRender(Boolean firstRender)
    {
#if DEBUG
        Console.WriteLine("OnAfterRender IsFirstRender: ");
        Console.WriteLine(JsonConvert.SerializeObject(firstRender));
        Debug.WriteLine("OnAfterRender IsFirstRender: ");
        Debug.WriteLine(JsonConvert.SerializeObject(firstRender));
#endif
        try
        {
            base.OnAfterRender(firstRender);
        }
        catch (Exception ex)
        {
#if DEBUG
            //log to console
            Console.WriteLine("exception Thrown");
            Console.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            Debug.WriteLine("exception Thrown");
            Debug.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            throw;
#endif
            throw new Exception("Exception: Problem occurred while performing after-render event.");
        }
    }
    protected override Task OnAfterRenderAsync(Boolean firstRender)
    {
#if DEBUG
        Console.WriteLine("OnAfterRenderAsync IsFirstRender: ");
        Console.WriteLine(JsonConvert.SerializeObject(firstRender));
        Debug.WriteLine("OnAfterRenderAsync IsFirstRender: ");
        Debug.WriteLine(JsonConvert.SerializeObject(firstRender));
#endif
        try
        {
            return base.OnAfterRenderAsync(firstRender);
        }
        catch (Exception ex)
        {
#if DEBUG
            //log to console
            Console.WriteLine("exception Thrown");
            Console.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            Debug.WriteLine("exception Thrown");
            Debug.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            throw;
#endif
            throw new Exception("Exception: Problem occurred while performing on-after-render async event.");
        }
    }
    protected override void OnInitialized()
    {
#if DEBUG
        Console.WriteLine("OnInitialized Component Initialized: ");
        Debug.WriteLine("OnInitialized Component Initialized: ");
#endif
        try
        {
            base.OnInitialized();
        }
        catch (Exception ex)
        {
#if DEBUG
            //log to console
            Console.WriteLine("exception Thrown");
            Console.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            Debug.WriteLine("exception Thrown");
            Debug.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            throw;
#endif
            throw new Exception("Exception: Problem occurred while performing on-initialized event.");
        }
    }
    protected override Task OnInitializedAsync()
    {
#if DEBUG
        Console.WriteLine("OnInitializedAsync Component Initialized: ");
        Debug.WriteLine("OnInitializedAsync Component Initialized: ");
#endif
        try
        {
            return base.OnInitializedAsync();
        }
        catch (Exception ex)
        {
#if DEBUG
            //log to console
            Console.WriteLine("exception Thrown");
            Console.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            Debug.WriteLine("exception Thrown");
            Debug.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            throw;
#endif
            throw new Exception("Exception: Problem occurred while performing on-initialized async async event.");
        }
    }
    protected override void OnParametersSet()
    {
#if DEBUG
        Console.WriteLine("OnParametersSet Parameters Set Successfully: ");
        Debug.WriteLine("OnParametersSet Parameters Set Successfully: ");
#endif
        try
        {
            base.OnParametersSet();
        }
        catch (Exception ex)
        {
#if DEBUG
            //log to console
            Console.WriteLine("exception Thrown");
            Console.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            Debug.WriteLine("exception Thrown");
            Debug.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            throw;
#endif
            throw new Exception("Exception: Problem occurred while performing on-paramters-set event.");
        }
    }
    protected override Task OnParametersSetAsync()
    {
#if DEBUG
        Console.WriteLine("OnParametersSetAsync Parameters Set Successfully: ");
        Debug.WriteLine("OnParametersSetAsync Parameters Set Successfully: ");
#endif
        try
        {
            return base.OnParametersSetAsync();
        }
        catch (Exception ex)
        {
#if DEBUG
            //log to console
            Console.WriteLine("exception Thrown");
            Console.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            Debug.WriteLine("exception Thrown");
            Debug.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            throw;
#endif
            throw new Exception("Exception: Problem occurred while performing on-paramters-set async event.");
        }
    }
    protected override Boolean ShouldRender()
    {
#if DEBUG
        Console.WriteLine("ShouldRender Page Will Render: ");
        Debug.WriteLine("ShouldRender Page Will Render: ");
#endif
        try
        {
            return base.ShouldRender();
        }
        catch (Exception ex)
        {
#if DEBUG
            //log to console
            Console.WriteLine("exception Thrown");
            Console.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            Debug.WriteLine("exception Thrown");
            Debug.WriteLine(ex.Message + Environment.NewLine + ex.Source + Environment.NewLine + ex.StackTrace);
            throw;
#endif
            throw new Exception("Exception: Problem occurred while performing should-render event.");
        }
    }
}