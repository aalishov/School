using System.Collections.Generic;

namespace MilitaryElite
{
    public interface ILieutenantGeneral
    {
        IReadOnlyCollection<Private> Privates { get; }

        void AddPrivate(Private @private);
        string ToString();
    }
}