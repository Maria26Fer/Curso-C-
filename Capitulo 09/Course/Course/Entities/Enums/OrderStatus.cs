namespace Course.Entities.Enums
{
    //Para especificar o tipo do meu enum uso : int para dizer que será do tipo inteiro;
    internal enum OrderStatus : int
    {
        //Aqui vai ficar a ordem do status do meu pedido:
        PendingPayment = 0, //Pendente
        Processing = 1, //Processando
        Shipped = 2, //Pago
        Delivered = 3, //Entregue
    }
}
