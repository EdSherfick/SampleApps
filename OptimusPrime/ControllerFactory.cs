using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusPrime
{
    public class ControllerFactory
    {
        public const int CONTROLLER_TYPE_SIMPLE = 1;
        public const int CONTROLLER_TYPE_COMPLETEX = 2;

        public static IPrimeController Create(int controlllerType)
        {
            IPrimeController controller = null;

            switch (controlllerType)
            {
                case CONTROLLER_TYPE_SIMPLE:
                    controller = new SimplePrimeController();
                    break;
                case CONTROLLER_TYPE_COMPLETEX:
                    controller = new SimplePrimeController();
                    throw new NotImplementedException("Hold on there buddy.  We're not ready yet.");
                default:
                    break;
            }

            return controller;
        }
    }
}
