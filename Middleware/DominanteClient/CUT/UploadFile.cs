using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominanteClient.CUT
{
    class UploadFile
    {
        private MSG msg;
        private CUC cuc;
        private string tokenApp;

        public UploadFile()
        {
            this.msg = new MSG();
            this.cuc = new CUC();
            this.tokenApp = "testToken";
        }

        public MSG Upload(MSG msg)
        {
            this.msg = msg;
            this.msg.tokenApp = this.tokenApp;
            this.msg.operationName = "decrypt";
            this.msg.operationVersion = "v1.0";
            this.msg.appVersion = "v1.0";

            // for testing porpuses only
            this.msg.statutOp = true;

            return this.msg;
        }
    }
}
