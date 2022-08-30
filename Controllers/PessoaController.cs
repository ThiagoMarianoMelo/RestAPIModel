using Microsoft.AspNetCore.Mvc;
using RestAPIModel.Models.MPessoa;
using RestAPIModel.Rules.RPessoa;

namespace RestAPIModel.Controllers.PessoaController{

    [Route("GerenciarPessoas")]
    public class PessoaController : ControllerBase{


    [Route("ListarPessoas")]
    [HttpGet]
    public  List<MPessoa> get(){
        return new RPessoa().returningAll();
    }

    [Route("CadastrarPessoa")]
    [HttpPost]
    public  void Post(MPessoa pessoa){
        new RPessoa().insertOnePerson( pessoa);
    }

    [Route("ExcluirPessoa")]
    [HttpDelete]
    public  void Delete(MPessoa pessoa){
        new RPessoa().deletingOnePerson(pessoa);
    }

    [Route("AtualizarDadosPessoa")]
    [HttpPut]
    public  void Put(MPessoa pessoa){
        new RPessoa().changeAtributesPerson(pessoa);
    }
}
}
