using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TkmStore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class TkmDBV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeCliente = table.Column<string>(type: "text", nullable: false),
                    EnderecoCliente = table.Column<string>(type: "text", nullable: false),
                    TelefoneCliente = table.Column<string>(type: "text", nullable: false),
                    EmailCliente = table.Column<string>(type: "text", nullable: false),
                    DataCadastroCliente = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeProduto = table.Column<string>(type: "text", nullable: false),
                    DescricaoProduto = table.Column<string>(type: "text", nullable: false),
                    PrecoProduto = table.Column<decimal>(type: "numeric", nullable: false),
                    EstoqueProduto = table.Column<int>(type: "integer", nullable: false),
                    DataCadastroProduto = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.IdProduto);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    IdVenda = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdCliente = table.Column<int>(type: "integer", nullable: true),
                    ClientesIdCliente = table.Column<int>(type: "integer", nullable: false),
                    IdProduto = table.Column<int>(type: "integer", nullable: true),
                    ProdutoIdProduto = table.Column<int>(type: "integer", nullable: false),
                    QuantidadeVenda = table.Column<int>(type: "integer", nullable: false),
                    DescricaoVenda = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.IdVenda);
                    table.ForeignKey(
                        name: "FK_Vendas_Clientes_ClientesIdCliente",
                        column: x => x.ClientesIdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vendas_Produtos_ProdutoIdProduto",
                        column: x => x.ProdutoIdProduto,
                        principalTable: "Produtos",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ClientesIdCliente",
                table: "Vendas",
                column: "ClientesIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ProdutoIdProduto",
                table: "Vendas",
                column: "ProdutoIdProduto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
