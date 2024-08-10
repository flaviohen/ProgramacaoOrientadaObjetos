
public class Produto {
	private int identificacao;
	private int identificacaoUnica;
	private String nomeProduto;
	private String caracteristicasDoProduto;
	
	public Produto() {}
	
	public Produto(int identificacao, int identificacaoUnica, String nomeProduto, String caracteristicasDoProduto) {
		this.identificacao = identificacao;
		this.identificacaoUnica = identificacaoUnica;
		this.nomeProduto = nomeProduto;
		this.caracteristicasDoProduto = caracteristicasDoProduto;
	}
	
	public void setIdentificacao(int identificacao) {
		this.identificacao = identificacao;
	}
	
	public int getIdentificacao() {
		return this.identificacao;
	}
	
	public void setIdentificacaoUnica(int identificacaoUnica) {
		this.identificacaoUnica = identificacaoUnica;
	}
	
	public int getIdentificacaoUnica() {
		return this.identificacaoUnica;
	}
	
	public void setNomeProduto(String nomeProduto) {
		this.nomeProduto = nomeProduto;
	}
	
	public String getNomeProduto() {
		return this.nomeProduto;
	}
	
	public void setCaracteristicasDoProduto(String caracteristicasDoProduto) {
		this.caracteristicasDoProduto = caracteristicasDoProduto;
	}
	
	public String getCaracteristicasDoProduto() {
		return this.caracteristicasDoProduto;
	}
}
