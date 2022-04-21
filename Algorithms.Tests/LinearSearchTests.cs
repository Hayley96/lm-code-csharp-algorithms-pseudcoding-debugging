using System.Collections.Generic;
using Algorithms.Models;
using NUnit.Framework;
using FluentAssertions;

namespace Algorithms.Tests
{
    public class LinearSearchTests
    {
        [Test]
        public void Should_Record_The_Search_Time_For_Worst_Case_With_A_Match()
        {
            // Arrange
            var contacts = new List<Contact>
            {
                new("Aaron", "Smith", "0207123434"),
                new("Ben", "Smith", "0207123434"),
                new("Ethan", "Smith", "0207123456"),
                new("Harry", "Smith", "0207123456"),
                new("Jane", "Smith", "0207123456"),
                new("Mike", "Smith", "0207123456"),
                new("Pamela", "Smith", "0207123456"),
                new("Tamara", "Smith", "0207123456"),
            };

            // Act
            int searchTime = LinearSearch.GetSearchTimeForContact(contacts, "Tamara");

            // Assert
            // Assuming it takes 200 ms to search per person
            searchTime.Should().Be(1600);
        }

        [Test]
        public void Should_Record_The_Search_Time_For_Worst_Case_Without_A_Match()
        {
            // Arrange
            var contacts = new List<Contact>
            {
                new("Aaron", "Smith", "0207123434"),
                new("Ben", "Smith", "0207123434"),
                new("Ethan", "Smith", "0207123456"),
                new("Harry", "Smith", "0207123456"),
                new("Jane", "Smith", "0207123456"),
                new("Mike", "Smith", "0207123456"),
                new("Pamela", "Smith", "0207123456"),
                new("Tamara", "Smith", "0207123456"),
            };

            // Act
            int searchTime = LinearSearch.GetSearchTimeForContact(contacts, "June");

            // Assert
            // Assuming it takes 200 ms to search per person
            searchTime.Should().Be(1800);
        }
    }
}
