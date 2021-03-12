using SearchResultFinder.Service;
using System;
using Xunit;

namespace SearchResultFinder.Tests
{
    public class SearchServiceTest
    {
        [Fact]
        public void GetSearchResult_WithoutUrl_ReturnDefaultSearchResult()
        {
            //Arrange
            var searchService = new GoogleSearchService();
            var expected = "0";
            

            //Act
            var actual = searchService.Search(null, "online title search");

            //Assert
            Assert.True(expected.Equals(actual), "Search result should be 0");

        }

        [Fact]
        public void GetSearchResult_WithoutKeywords_ReturnDefaultSearchResult()
        {
            //Arrange
            var searchService = new GoogleSearchService();
            var expected = "0";


            //Act
            var actual = searchService.Search("www.infotrack.com.au", null);

            //Assert
            Assert.True(expected.Equals(actual), "Search result should be 0");

        }

        [Fact]
        public void GetSearchResult_WithEmptyInputs_ReturnDefaultSearchResult()
        {
            //Arrange
            var searchService = new GoogleSearchService();
            var expected = "0";


            //Act
            var actual = searchService.Search(string.Empty, string.Empty);

            //Assert
            Assert.True(expected.Equals(actual), "Search result should be 0");

        }

        [Fact]
        public void GetSearchResult_WithValidInputs_ReturnDefaultSearchResult()
        {
            //Arrange
            var searchService = new GoogleSearchService();
            var expected = "1,2";


            //Act
            var actual = searchService.Search("www.infotrack.com.au", "online title search");

            //Assert
            Assert.True(expected.Equals(actual), "Search result should not be 0");

        }


    }
}
