using System;
using System.Threading.Tasks;
using SharpBrick.PoweredUp;

namespace Example
{
    public class ExampleMoveHubColors : BaseExample
    {
        public override async Task ExecuteAsync()
        {
            using (var technicMediumHub = Host.FindByType<MoveHub>())
            {
                await technicMediumHub.RgbLight.SetRgbColorsAsync(0x00, 0xff, 0x00);

                await Task.Delay(2000);

                await technicMediumHub.RgbLight.SetRgbColorsAsync(0xff, 0x00, 0x00);

                await Task.Delay(2000);

                await technicMediumHub.SwitchOffAsync();
            }
        }
    }
}