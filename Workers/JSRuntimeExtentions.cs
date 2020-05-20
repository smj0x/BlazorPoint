using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace dc.Workers
{
    public static class JSRuntimeExtentions
    {
        public static ValueTask SaveAs(this IJSRuntime js, byte[] data)
            => js.InvokeVoidAsync(
                "smj.interop.saveAsFile",
                "DVL-" + DateTime.Now.ToString("ddMMyyyyHH:mm:ss") + ".xlsx",
                Convert.ToBase64String(data));
    }
}
