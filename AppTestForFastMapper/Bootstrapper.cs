using System;

namespace AppTestForFastMapper
{
    public class Bootstrapper
    {
        public void AutomapperInit()
        {
            //Inicialização dos Mapeamentos
            AutoMapper.Mapper.CreateMap<PessoaDto,Pessoa>();
            AutoMapper.Mapper.CreateMap<Pessoa,PessoaDto>();
        }
    }
}

