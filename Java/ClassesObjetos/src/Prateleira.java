
public class Prateleira {
	private int codigoProduto;
	private int quantidadeProduto;
	private float precoProduto;
	
	public Prateleira() {}
	
	public Prateleira(int codigoProduto, int quantidadeProduto, float precoProduto) {
		this.codigoProduto = codigoProduto;
		this.quantidadeProduto = quantidadeProduto;
		this.precoProduto = precoProduto;
	}
	
	public void setCodigoProduto(int codigoProduto) {
		this.codigoProduto = codigoProduto;
	}
	
	public int getCodigoProduto() {
		return this.codigoProduto;
	}
	
	public void setQuantidadeProduto(int quantidadeProduto) {
		this.quantidadeProduto = quantidadeProduto;
	}
	
	public int getQuantidadeProduto() {
		return this.quantidadeProduto;
	}
	
	public void setPrecoProduto(float precoProduto) {
		this.precoProduto = precoProduto;
	}
	
	public float getPrecoProduto() {
		return this.precoProduto;
	}
}
