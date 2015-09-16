using Microsoft.AspNet.Mvc;
using Microsoft.Framework.Configuration;
using Microsoft.Framework.OptionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TKDemoMVC.Controllers {
    public class Data123Config {
        public int Value1 { get; set; }
        public string Value2 { get; set; }
        public DefaultConnectionClass DefaultConnection { get; set; }
    }

    public class DefaultConnectionClass {
        public string ConnectionString { get; set; }
    }
    public class OptionsController : Controller {
        AppSettingsConfig Options { get; }
        Data123Config Data { get; }
        SecretsConfig Secrets { get; }
        public OptionsController(IOptions<AppSettingsConfig> opt, IOptions<Data123Config> dat, IOptions<SecretsConfig> sec) {
            Options = opt.Options;
            Data = dat.Options;
            //user-secret.cmd set AzureKey ABC
            Secrets = sec.Options;
        }
        public IActionResult Index() {
            return View(); //Maybe using model?
        }
    }
}
