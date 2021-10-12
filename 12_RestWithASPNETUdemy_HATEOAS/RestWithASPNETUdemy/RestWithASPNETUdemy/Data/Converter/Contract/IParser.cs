using System.Collections.Generic;

namespace RestWithASPNETUdemy.Data.Converter.Contract
{
    interface IParser<O, D>
    {
        D Parse(O origin);
        List<D> Parse(List<O> origin);
    }
}
