using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects;

[TestClass]
public class DocumentTests
{
    // RED, GREEN, REFACTOR
    [TestMethod]
    public void ShouldReturnErrorWhenCNPJIsInvalid()
    {
        var doc = new Document("123", EDocumentType.CNPJ);
        Assert.IsFalse(doc.IsValid);
    }

    [TestMethod]
    public void ShouldReturnSucccessWhenCNPJIsValid()
    {
        var doc = new Document("73186443000192", EDocumentType.CNPJ);
        Assert.IsTrue(doc.IsValid);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenCPFIsInvalid()
    {
        var doc = new Document("123", EDocumentType.CPF);
        Assert.IsFalse(doc.IsValid);
    }

    [TestMethod]
    [DataTestMethod]
    [DataRow("15545095055")]
    [DataRow("13352187002")]
    [DataRow("56012061346")]
    public void ShouldReturnSucccessWhenCPFIsValid(string cpf)
    {
        var doc = new Document(cpf, EDocumentType.CPF);
        Assert.IsTrue(doc.IsValid);
    }
}