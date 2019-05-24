using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static class Launcher
    {
        public static void Launch(int challengeNumber)
        {
            switch (challengeNumber)
            {
                case 001:
                    _001.DoWork(1000);
                    break;
                case 002:
                    _002.DoWork(4000000);
                    break;
                case 003:
                    _003.DoWork(600851475143);
                    break;
                case 004:
                    _004.DoWork(1000);
                    break;
                case 005:
                    _005.DoWork(20);
                    break;
                case 006:
                    _006.DoWork(100);
                    break;
                case 007:
                    _007.DoWork(10001);
                    break;
                case 008:
                    _008.DoWork();
                    break;
                case 009:
                    _009.DoWork(1000);
                    break;
                case 010:
                    _010.DoWork(2000000);
                    break;
                case 011:
                    _011.DoWork(20);
                    break;
                case 012:
                    _012.DoWork(501);
                    break;
                case 013:
                    _013.DoWork(50);
                    break;
                case 014:
                    _014.DoWork(1000000);
                    break;
                default:
                    break;
            }
        }
    }
}
