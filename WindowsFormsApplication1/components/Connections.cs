﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.components
{
    class Connections
    {
        components.Values val = new components.Values();

        public string conString()
        {
            return String.Format("datasource={0};username={1};password={2};",
                                val.server_name, val.server_user, val.server_password);
        }
    }
}
