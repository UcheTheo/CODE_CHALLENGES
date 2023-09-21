class ValidAnagramChallenge(object):
    def validAnagram(str1: str, str2: str) -> bool:
        str_freq: dict = {}

        for c in str1:
            str_freq[c] = str_freq.get(c, 0) + 1

        for c in str2:
            str_freq[c] = str_freq.get(c, 0) - 1

        print(str_freq)
        for value in str_freq.values():
            if value != 0:
                return False
        return True


print(ValidAnagramChallenge.validAnagram("poolnn", "npolon"))
