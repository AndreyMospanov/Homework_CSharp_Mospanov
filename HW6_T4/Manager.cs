using System;

namespace HW6_T4
{
    internal class Manager : Worker
    {
        public Manager(string name)
        {
            Name = name;
        }

        public override string Name { get; set; }

        public override string Print()
        {
            return "Ме́неджер (англ. manager, от manage — «управлять»), руководи́тель, управля́ющий — специалист, занятый управлением процессами и персоналом (подчинёнными) на определённом участке коммерческого (торгового и иных) предприятия, организации.Менеджер может быть владельцем коммерческого предприятия (организации), но часто является наёмным работником. Менеджер, как правило, является должностным лицом на предприятия (в организации), в которой работает, и входит в средний и высший руководящий состав компании, предприятия. Определяющим признаком управляющего является наличие подчинённых. Основная функция менеджера — управление, включающее процесс планирования, организации, мотивации и контроля. В зависимости от величины и количества объектов управления различают уровни управления, а следовательно, и менеджеров.";
        }
    }
}
