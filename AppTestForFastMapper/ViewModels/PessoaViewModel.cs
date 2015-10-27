using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppTestForFastMapper
{
    /// <summary>
    /// Classe para alimentar a View.
    /// </summary>
    public class PessoaViewModel
    {
        public ICommand Click_Adicionar_Pessoa { get; protected set; }

        public PessoaDto PessoaDto { get; set; }

        public PessoaViewModel()
        {
            this.PessoaDto = new PessoaDto();
            this.Click_Adicionar_Pessoa = new Command(() => this.Add());
        }

        public bool Add()
        {
            try
            {
                var pessoa = AutoMapper.Mapper.Map<Pessoa>(this.PessoaDto);

                if (pessoa != null)
                    return pessoa.GetType() == typeof(Pessoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return false;
        }
    }
}

