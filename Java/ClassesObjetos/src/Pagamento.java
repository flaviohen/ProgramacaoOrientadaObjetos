
public class Pagamento {
	private int identificacao;
	private String tipoPagamento;
	
	public Pagamento() {}
	
	public Pagamento(int identificacao, String tipoPagamento) {
		this.identificacao = identificacao;
		this.tipoPagamento = tipoPagamento;
	}
	
	public void setIdentificacao(int identificacao) {
		this.identificacao = identificacao;
	}
	
	public int getIdentificacao() {
		return this.identificacao;
	}
	
	public void setTipoPagamento(String tipoPagamento) {
		this.tipoPagamento = tipoPagamento;
	}
	
	public String getTipoPagamento() {
		return this.tipoPagamento;
	}
}
