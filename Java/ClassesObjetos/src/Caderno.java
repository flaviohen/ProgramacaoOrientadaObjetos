import java.util.Date;
public class Caderno {
	private int identificacao;
	private int codigoProduto;
	private int quantidadeVendida;
	private float totalVenda;
	private Date dataVenda;
	private int tipoPagamento;
	
	public Caderno() {}
	
	public Caderno(int identificacao, int codigoProduto, int quantidadeVendida, float totalVenda, Date dataVenda, int tipoPagamento) {
		this.identificacao = identificacao;
		this.codigoProduto = codigoProduto;
		this.quantidadeVendida = quantidadeVendida;
		this.totalVenda = totalVenda;
		this.dataVenda = dataVenda;
		this.tipoPagamento = tipoPagamento;
	}
	
	public void setIdentificacao(int identificacao) {
		this.identificacao = identificacao;
	}
	
	public int getIdentificacao() {
		return this.identificacao;
	}
	
	public void setCodigoProduto(int codigoProduto) {
		this.codigoProduto = codigoProduto;
	}
	
	public int getCodigoProduto() {
		return this.codigoProduto;
	}
	
	public void setQuantidadeVendida(int quantidadeVendida) {
		this.quantidadeVendida = quantidadeVendida;
	}
	
	public int getQuantidadeVendida() {
		return this.quantidadeVendida;
	}
	
	public void setTotalVenda(float totalVenda) {
		this.totalVenda = totalVenda;
	}
	
	public float getTotalVenda() {
		return this.totalVenda;
	}
	
	public void setDataVenda(Date dataVenda) {
		this.dataVenda = dataVenda;
	}
	
	public Date getDataVenda() {
		return this.dataVenda;
	}
	
	public void setTipoPagamento(int tipoPagamento) {
		this.tipoPagamento = tipoPagamento;
	}
	
	public int getTipoPagamento() {
		return this.tipoPagamento;
	}
	
	public void RegistrarVenda(Caderno registro) {
		System.out.println("Registro: " + registro.getIdentificacao() + "-" + registro.getCodigoProduto() + "-" + registro.getQuantidadeVendida() + "-" + registro.getDataVenda() + "-" + registro.getTipoPagamento());
	}
	
	public void RegistrarVenda(Caderno registro, String pagamento) {
		System.out.println("Registro Venda: " + registro.getIdentificacao() + "-" + registro.getCodigoProduto() + "-" + registro.getQuantidadeVendida() + "-" + registro.getTotalVenda() + "-" + registro.getDataVenda() + '-' + pagamento);
	}
	
	public void RegistrarVenda(Caderno registro, Pagamento pagamento) {
		System.out.println("Registro Venda: " + registro.getIdentificacao() + "-" + registro.getCodigoProduto() + "-" + registro.getQuantidadeVendida() + "-" + registro.getTotalVenda() + "-" + registro.getDataVenda() + "-" + pagamento.getIdentificacao() + "-" + pagamento.getTipoPagamento());
	}
	
	public void RegistrarVenda(Caderno registro, Produto produto, Pagamento pagamento) {
		System.out.println("Registro Venda: " + registro.getIdentificacao() + "-" + produto.getIdentificacao() + "-" + produto.getNomeProduto() + "-" + registro.getQuantidadeVendida() + "-" + registro.getTotalVenda() + "-" + registro.getDataVenda() + "-" + pagamento.getIdentificacao() + "-" + pagamento.getTipoPagamento());
	}
}