function abrirModal() {
    $('#modal').addClass('modal-show');
    $('.modal-content').addClass('modal-content-show');
}
function fecharModal() {
    $('#modal').removeClass('modal-show');
    $('.modal-content').removeClass('modal-content-show');
}

/* ----------MODAL CLIENTES----------- */
function abrirModalDetalhesCliente(ID) {
    var nome = $('#nome_' + ID).val();
    var cpf = $('#cpf_' + ID).val();
    var cnpj = $('#cnpj_' + ID).val();
    var rg = $('#rg_' + ID).val();
    var idade = $('#idade_' + ID).val();
    var nascimento = $('#dataNascimento_' + ID).val();
    var profissao = $('#profissao_' + ID).val();
    var telefone = $('#telefone_' + ID).val();
    var celular = $('#celular_' + ID).val();
    var email = $('#email_' + ID).val();
    var logradouro = $('#logradouro_' + ID).val();
    var numero = $('#numero_' + ID).val();
    var bairro = $('#bairro_' + ID).val();
    var municipio = $('#municipio_' + ID).val();
    var uf = $('#uf_' + ID).val();
    var cep = $('#cep_' + ID).val();

    document.querySelector("#modal-content").innerHTML =
        `<div style="display:flex; justify-content: space-between;">
            <div style="text-align: left;">
                <h1>Informações do cliente</h1>
            </div>
            <div class="btn-modal no-print" style="text-align: right;">
                <button class="btn btn-danger close" onclick="fecharModal()" id="close"><i class="fa fa-close"></i></button>
            </div>
        </div>
        <br class="dont-print">
        <div id="info-modal" class="conteudo">`+
            '<input type="hidden" value="" id="id_cliente"/>' +
            '<p><b>Nome: </b>' + nome + '</p>' +
            '<p><b>CPF: </b>' + cpf + '</p>' +
            '<p><b>CNPJ: </b>' + cnpj + '</p>' +
            '<p><b>RG: </b>' + rg + '</p>' +
            '<p><b>Idade: </b>' + idade + '</p>' +
            '<p><b>Data de Nascimento: </b>' + nascimento + '</p>' +
            '<p><b>Profissão: </b>' + profissao + '</p>' +
            '<p><b>Telefone: </b>' + telefone + '</p>' +
            '<p><b>Celular: </b>' + celular + '</p>' +
            '<p><b>Email: </b>' + email + '</p>' +
            '<p style="width:500px;"><b>Endereço completo: </b>' +
            logradouro + ', N°' + numero + ', ' + bairro + ', ' + municipio + ' - ' + uf + '. CEP:' + cep + '</p>' + '<br><br>' +
        `</div>
        <div class="btn-modal no-print" style="text-align: center;">
            <button class="btn btn-success" onclick="window.print()"><i class="fa fa-print"></i> Imprimir</button>
        </div>`;

    abrirModal()
};
function abrirModalAdicionarCliente() {

    document.querySelector("#modal-content").innerHTML = 
        `<div style="display:flex; justify-content: space-between;">
            <div style="text-align: left;">
                <h1>Adicionar dados do cliente</h1>
            </div>
            <div class="btn-modal no-print" style="text-align: right;">
                <button class="btn btn-danger close" onclick="fecharModal()" id="close"><i class="fa fa-close"></i></button>
            </div>
        </div>
        <br class="dont-print">

        <div id="info-modal" class="conteudo">
            <form class="row" id="formulario">
                <div class="col-md-4 mb-4">
                    <label><b>Nome:</b></label>
                    <input type="text" class="form-control" value="" name="CLI_NOME" id="CLI_NOME">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>Profissão:</b></label>
                    <input type="text" class="form-control" value="" name="CLI_PROFISSAO" id="CLI_PROFISSAO">
                    <br class="dont-print">
                </div>
                <div class="col-md-2 mb-2">
                    <label><b>Sexo:</b></label>
                    <select class="form-select" name="CLI_SEXO" id="CLI_SEXO" value="">
                        <option value="" selected>Selecione</option>
                        <option value="0">Masculino</option>
                        <option value="1">Feminino</option>
                    </select>
                    <br class="dont-print">
                </div>
                <div class="col-md-2 mb-2">
                    <label><b>Data de Nascimento:</b></label>
                    <input type="date" class="form-control date" value="" name="CLI_DATA_NASC" id="CLI_DATA_NASC">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>CPF:</b></label>
                    <input type="text" class="form-control cpf" value="" name="CLI_CPF" id="CLI_CPF" placeholder="###.###.###-##" onkeyup="mascara('###.###.###-##',this,event,true)" maxlength="14">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>CNPJ:</b></label>
                    <input type="text" class="form-control cnpj" value="" name="CLI_CNPJ" id="CLI_CNPJ" placeholder="##.###.###/####-##" onkeyup="mascara('##.###.###/####-##',this,event,true)" maxlength="18">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>RG:</b></label>
                    <input type="text" class="form-control" value="" name="CLI_RG" id="CLI_RG" placeholder="##.###.###-#" onkeyup="mascara('##.###.###-#',this,event,true)" maxlength="12">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>Telefone:</b></label>
                    <input type="text" class="form-control" value="" name="CLI_TELEFONE" id="CLI_TELEFONE" placeholder="(##)####.####" onkeyup="mascara('(##)####.####',this,event,true)" maxlength="13">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>Celular:</b></label>
                    <input type="text" class="form-control" value="" name="CLI_CELULAR" id="CLI_CELULAR" placeholder="(##)#####.####" onkeyup="mascara('(##)#####.####',this,event,true)" maxlength="14">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>Email:</b></label>
                    <input type="text" class="form-control" value="" name="CLI_EMAIL" id="CLI_EMAIL">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>CEP:</b></label>
                    <input type="text" class="form-control" value="" name="CLI_CEP" id="cep" onblur="buscarCep()" placeholder="##.###-###" onkeyup="mascara('##.###-###',this,event,true)" maxlength="10">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>Logradouro:</b></label>
                    <input type="text" class="form-control" value="" name="CLI_LOGRADOURO" id="logradouro">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>Complemento:</b></label>
                    <input type="text" class="form-control" value="" name="CLI_COMPLEMENTO" id="complemento">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>Bairro:</b></label>
                    <input type="text" class="form-control" value="" name="CLI_BAIRRO" id="bairro">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>Município:</b></label>
                    <input type="text" class="form-control" value="" name="CLI_MUNICIPIO" id="localidade">
                    <br class="dont-print">
                </div>
                <div class="col-md-2 mb-2">
                    <label><b>UF:</b></label>
                    <input type="text" class="form-control" value="" name="CLI_UF" id="uf">
                    <br class="dont-print">
                </div>
                <div class="col-md-2 mb-2">
                    <label><b>Número:</b></label>
                    <input type="text" class="form-control" value="" name="CLI_NUMERO" id="numero">
                    <br class="dont-print">
                </div>
            </form>
        </div>
        <div class="btn-modal no-print" style="text-align: center;">
            <button class="btn-cadastrar" onclick="adicionarCliente()"><i class="fa fa-plus"></i>   Adicionar</button>
        </div>`;

    abrirModal()
};
function abrirModalAtualizarCliente(ID) {
    var nome = $('#nome_' + ID).val();
    var cpf = $('#cpf_' + ID).val();
    var cnpj = $('#cnpj_' + ID).val();
    var rg = $('#rg_' + ID).val();
    var profissao = $('#profissao_' + ID).val();
    var telefone = $('#telefone_' + ID).val();
    var celular = $('#celular_' + ID).val();
    var email = $('#email_' + ID).val();
    var logradouro = $('#logradouro_' + ID).val();
    var numero = $('#numero_' + ID).val();
    var bairro = $('#bairro_' + ID).val();
    var municipio = $('#municipio_' + ID).val();
    var complemento = $('#complemento_' + ID).val();
    var uf = $('#uf_' + ID).val();
    var cep = $('#cep_' + ID).val();

    document.querySelector("#modal-content").innerHTML = 
        `<div style="display:flex; justify-content: space-between;">
            <div style="text-align: left;">
                <h1>Atualizar dados do cliente</h1>
            </div>
            <div class="btn-modal no-print" style="text-align: right;">
                <button class="btn btn-danger close" onclick="fecharModal()" id="close"><i class="fa fa-close"></i></button>
            </div>
        </div>

        <br class="dont-print">
        <div id="info-modal" class="conteudo">

            <form class="row" id="formulario">
                <input type="hidden" name="CLI_ID" value="`+ ID + `" />
                <div class="col-md-4 mb-4">
                    <label><b>Nome:</b></label>
                    <input type="text" class="form-control" value="`+ nome + `" name="CLI_NOME" id="CLI_NOME">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>Profissão:</b></label>
                    <input type="text" class="form-control" value="`+ profissao + `" name="CLI_PROFISSAO" id="CLI_PROFISSAO">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>CPF:</b></label>
                    <input type="text" class="form-control cpf" value="`+ cpf + `" name="CLI_CPF" id="CLI_CPF" placeholder="###.###.###-##" onkeyup="mascara('###.###.###-##',this,event,true)" maxlength="14">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>CNPJ:</b></label>
                    <input type="text" class="form-control cnpj" value="`+ cnpj + `" name="CLI_CNPJ" id="CLI_CNPJ" placeholder="##.###.###/####-##" onkeyup="mascara('##.###.###/####-##',this,event,true)" maxlength="18">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>RG:</b></label>
                    <input type="text" class="form-control" value="`+ rg + `" name="CLI_RG" id="CLI_RG" placeholder="##.###.###-#" onkeyup="mascara('##.###.###-#',this,event,true)" maxlength="12">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>Telefone:</b></label>
                    <input type="text" class="form-control" value="`+ telefone + `" name="CLI_TELEFONE" id="CLI_TELEFONE" placeholder="(##)####.####" onkeyup="mascara('(##)####.####',this,event,true)" maxlength="13">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>Celular:</b></label>
                    <input type="text" class="form-control" value="`+ celular + `" name="CLI_CELULAR" id="CLI_CELULAR" placeholder="(##)#####.####" onkeyup="mascara('(##)#####.####',this,event,true)" maxlength="14">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>Email:</b></label>
                    <input type="text" class="form-control" value="`+ email + `" name="CLI_EMAIL" id="CLI_EMAIL">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>CEP:</b></label>
                    <input type="text" class="form-control" value="`+ cep + `" name="CLI_CEP" id="cep" placeholder="##.###-###" onkeyup="mascara('##.###-###',this,event,true)" maxlength="10">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>Logradouro:</b></label>
                    <input type="text" class="form-control" value="`+ logradouro + `" name="CLI_LOGRADOURO" id="logradouro">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>Complemento:</b></label>
                    <input type="text" class="form-control" value="`+ complemento + `" name="CLI_COMPLEMENTO" id="complemento">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>Bairro:</b></label>
                    <input type="text" class="form-control" value="`+ bairro + `" name="CLI_BAIRRO" id="bairro">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>Município:</b></label>
                    <input type="text" class="form-control" value="`+ municipio + `" name="CLI_MUNICIPIO" id="localidade">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>UF:</b></label>
                    <input type="text" class="form-control" value="`+ uf + `" name="CLI_UF" id="uf">
                    <br class="dont-print">
                </div>
                <div class="col-md-4 mb-4">
                    <label><b>Número:</b></label>
                    <input type="text" class="form-control" value="`+ numero + `" name="CLI_NUMERO" id="numero">
                    <br class="dont-print">
                </div>
            </form>
        </div>
        <div class="btn-modal no-print" style="text-align: center;">
            <button class="btn-cadastrar" onclick="atualizarCliente()" style="background-color:#ffc107; color:#000; font-weight: bold;"><i class="fa fa-pencil"></i>  Atualizar</button>
        </div>`;

    abrirModal()
};
function abrirModalDeletarCliente(ID) {
    var nome = $('#nome_' + ID).val();

    document.querySelector("#modal-content").innerHTML =
        `<div class="btn-modal no-print" style="text-align: right;">
            <button class="btn btn-danger close" onclick="fecharModal()" id="close"><i class="fa fa-close"></i></button>
        </div>  
        <form style="display:none" id="formulario">
            <input type="hidden" name="CLI_ID" value="`+ ID + `" />
        </form>
        <div id="info-modal" class="conteudo text-center m-3">
            <h4 style="width:500px;">
                <i class="fa fa-exclamation-circle fa-4x" style="color:#dc3545; margin-top:-40px;margin-bottom:10px;"></i>
                <br/>Deseja mesmo deletar `+ nome + ` da sua lista de clientes?
            </h4>
        </div>
        <div class="btn-modal no-print" style="text-align: center;">
            <button class="btn-cadastrar bg-danger" onclick="deletarCliente()">Deletar</button>
        </div>`;

    abrirModal();
};

