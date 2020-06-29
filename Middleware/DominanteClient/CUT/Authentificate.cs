using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominanteClient.CUT
{
    class Authentificate
    {
        private MSG msg;
        private CUC cuc;
        private string tokenApp;

        public Authentificate()
        {
            this.msg = new MSG();
            this.cuc = new CUC();
            this.tokenApp = "testToken";
        }

        public MSG Authentify(MSG msg)
        {
            this.msg = msg;
            this.msg.tokenApp = this.tokenApp;
            this.msg.operationName = "authentificate";
            this.msg.operationVersion = "v1.0";
            this.msg.appVersion = "v1.0";

            // for testing porpuses only
            this.msg.statutOp = true;

            return this.msg;
        }
    }
}
