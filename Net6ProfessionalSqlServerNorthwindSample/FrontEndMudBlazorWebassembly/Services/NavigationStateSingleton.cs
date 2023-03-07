/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components;
using System.Net.NetworkInformation;
namespace Northwind_FrontEndMudBlazorWebassembly.Services
{
    public class NavigationStateSingleton
    {
        public Boolean NavigationMenuOpen { get; set; } = false;
        public void DrawerToggle(Boolean toggledFromHamburger = false)
        {
            if (toggledFromHamburger)
                NavigationMenuOpen = !NavigationMenuOpen;
            else if (NavigationMenuOpen)
                NavigationMenuOpen = false;
        }        
    }
}
