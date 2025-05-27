using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodySortowania.Interfaces;
using MetodySortowania.SortTypes;

namespace MetodySortowania.Tests
{
    public class InsertionSortTests
    {
        ISort sortMethod = new InsertionSort();

        [Fact]
        public void Sort_ForSingleElementArray_ReturnArray()
        {
            // arrange
            int[] singleElementArray = new int[] { 777 };

            // act
            int[] resultArray = sortMethod.Sort<int>(singleElementArray);

            // assert
            Assert.Equal(resultArray, new int[] { 777 });
        }


        [Theory]
        [InlineData(new int[] { 3, 4, 2, 5, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 2, 2, 1, 3 }, new int[] { 1, 2, 2, 3 })]
        [InlineData(new int[] { -4, -6, 0, 0, 2, 3, 4, 5, 8, 11, 12, -4, 5, 7, -11, 11 }, new int[] { -11, -6, -4, -4, 0, 0, 2, 3, 4, 5, 5, 7, 8, 11, 11, 12 })]
        [InlineData(new int[] { 1, -1 }, new int[] { -1, 1 })]
        public void Sort_ForIntArray_ReturnSortedArray(int[] array, int[] sortedArray)
        {
            // arrange

            // act
            int[] resultArray = sortMethod.Sort<int>(array);

            // assert
            Assert.Equal(resultArray, sortedArray);
        }


        [Theory]
        [InlineData(new char[] { 'd', 'c', 'a', 'b', 'e' }, new char[] { 'a', 'b', 'c', 'd', 'e' })]
        [InlineData(new char[] { 'b', 'a' }, new char[] { 'a', 'b' })]
        [InlineData(new char[] { 'c', 'b', 'a', 'g', 'm', 'f', 'd', 'g', 'h', 'i', 'o', 'k', 'k', 'l', 'e', 'n', 'j' }, new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'g', 'h', 'i', 'j', 'k', 'k', 'l', 'm', 'n', 'o' })]
        public void Sort_ForCharArray_ReturnSortedArray(char[] array, char[] sortedArray)
        {
            // arrange

            // act
            char[] resultArray = sortMethod.Sort<char>(array);

            // assert
            Assert.Equal(resultArray, sortedArray);
        }


        [Fact]
        public void Sort_ForPersonArray_ReturnSortedArray()
        {
            // arrange
            Person[] personArray = new Person[]
            {
                new Person("Christian", "Bale"),
                new Person("Tom", "Cruise"),
                new Person("Rebecca", "Ferguson"),
                new Person("Hayley", "Atwell"),
                new Person("Henry", "Cavill"),
            };

            Person[] sortedPersonArray = new Person[]
            {
                new Person("Hayley", "Atwell"),
                new Person("Christian", "Bale"),
                new Person("Henry", "Cavill"),
                new Person("Tom", "Cruise"),
                new Person("Rebecca", "Ferguson"),
            };


            // act
            Person[] resultArray = sortMethod.Sort<Person>(personArray);

            // assert
            Assert.Equal(personArray, sortedPersonArray);
        }
    }
}
