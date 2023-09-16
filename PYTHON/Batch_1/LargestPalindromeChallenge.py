import time

class LargestPalindromeChallenge(object):
    def isPalindromeStr(self, x) -> bool:
        x = str(x)
        return x == x[::-1]

    def isPalindrome(self, num: int) -> bool:
        if num < 0 or (num != 0 and num % 10 == 0):
            return False
        
        half: int = 0

        while num > half:
            half = (half * 10) + (num % 10)
            num //= 10

        return (num == half or num == half // 10)

    def myPow(self, x: float, n: int) -> float:
        if n < 0:
            n = -1 * n
            x = 1 / x

        pow: float = 1
        while n != 0:
            if n % 2 != 0: pow *= x
            if n == 1: break
            x *= x
            n //= 2
        return pow

    def LargestPalindrome(self, n: int) -> int:
        maxNum: int = self.myPow(10, n) - 1
        minNum: int = (maxNum + 1) // 10
        largestPalindrome: int = 0

        for i in range(maxNum, minNum + 1, -1):
            for j in range(i, minNum + 1, -1):
                prod: int = i * j
                if prod <= largestPalindrome: break
                if self.isPalindrome(prod): largestPalindrome = prod
        return largestPalindrome

palindrome = LargestPalindromeChallenge()

t0 = time.time()
print(palindrome.LargestPalindrome(3))
t1 = time.time()

print("Total time spent: {}".format(round(t1 - t0, 5)))