using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CheckBoxForMediatorPattern
{
    class Mediator
    {
        private CheckBox rKnight;
        private CheckBox rBerserker;
        private CheckBox rWizard;

        private CheckBox rOne;
        private CheckBox rTwo;
        private CheckBox rStaff;
        
        public Mediator()
        {

        }

        public void Add( CheckBox knight, CheckBox berserker, CheckBox wizard)
        {
            rKnight = knight;
            rBerserker = berserker;
            rWizard = wizard;
        }

        public void AddSecond(CheckBox one, CheckBox two, CheckBox staff)
        {
            rOne = one;
            rTwo = two;
            rStaff = staff;
        }

        public void Check(CheckBox obj)
        {
            obj.Checked = true;
        }
        public void UnCheck(CheckBox obj)
        {
            obj.Checked = false;
        }

        public void ChangeAction(CheckBox obj)
        {
            if (rKnight.Equals(obj))
            {
                UnCheck( rBerserker );
                UnCheck( rWizard );

                Check( rOne );
                UnCheck(rStaff);
                UnCheck(rTwo);
            }
            else if (rBerserker.Equals(obj))
            {
                UnCheck(rKnight);
                UnCheck(rWizard);

                Check(rOne);
                UnCheck(rStaff);
                Check(rTwo);
            }
            else if (rWizard.Equals(obj))
            {
                UnCheck(rBerserker);
                UnCheck(rKnight);

                UnCheck(rOne);
                Check(rStaff);
                UnCheck(rTwo);
            }
        }
    }
}
