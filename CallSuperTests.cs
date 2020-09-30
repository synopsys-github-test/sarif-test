// (c) 2012-2020 Coverity, Inc. All rights reserved worldwide.
using System;
using System.Collections.Generic;
using System.Text;

namespace CallSuperTest
{

    class XA {
        public virtual void foo() { }
    }
    class XB1 : XA {
        public override void foo() { base.foo(); }
    }

    class XC : XB1 { }
    class XD1 : XC {
        public override void foo() { base.foo(); }
    }
    class XD2 : XC {
        public override void foo() { base.foo(); }
    }
    class XD3 : XC {

        //#defect#CALL_SUPER
        public override void foo() { Console.Write(""); }
    }

    
}
