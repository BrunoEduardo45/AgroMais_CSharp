function abrirModal(){
    $('#modal').addClass('modal-show');             
    $('.modal-content').addClass('modal-content-show');             
}
function fecharModal(){
    $('#modal').removeClass('modal-show');
    $('.modal-content').removeClass('modal-content-show');
}    
$(document).ready(function () {
    $('#datatable').DataTable();
});
$('#datatable').DataTable({
    "ordering": true,
    "paging": true,
    "searching": true,
    "oLanguage": {
        "sEmptyTable": "Nenhum registro encontrado na tabela",
        "sInfo": "Mostrar _START_ at� _END_ de _TOTAL_ registros",
        "sInfoEmpty": "Mostrar 0 at� 0 de 0 Registros",
        "sInfoFiltered": "(Filtrar de _MAX_ total registro)",
        "sInfoPostFix": "",
        "sInfoThousands": ".",
        "sLengthMenu": "Mostrar _MENU_ registros por p�gina",
        "sLoadingRecords": "Carregando...",
        "sProcessing": "Processando...",
        "sZeroRecords": "Nenhum registro encontrado",
        "sSearch": "Pesquisar",
        "oPaginate": {
            "sNext": "Pr�ximo",
            "sPrevious": "Anterior",
            "sFirst": "Primeiro",
            "sLast": "Ultimo"
        },
        "oAria": {
            "sSortAscending": ": Ordenar colunas de forma ascendente",
            "sSortDescending": ": Ordenar colunas de forma Descendente"
        }
    }
})