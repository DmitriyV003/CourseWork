<template>
  <q-page padding>
    <BankAccountsTable :loadingTable="loadingTable" :data="bankAccounts" />
  </q-page>
</template>

<script>
import BankAccountsTable from 'components/tables/BankAccountsTable'
export default {
  name: 'PageBankAccountAll',
  components: {
    BankAccountsTable
  },
  data: () => {
    return {
      loadingTable: false,
      data: [
        { name: 'JJJJddfdf', currency: 'RUB', accountNumber: '30101810300000000747', bank: 'dfgdfhg', bic: 18515265, company: 'Company name' },
        { name: 'JJJJddfdf', currency: 'RUB', accountNumber: '30101810300000000747', bank: 'dfgdfhg', bic: 18515265, company: 'Company name' }
      ]
    }
  },
  computed: {
    bankAccounts () {
      return this.$store.state.bankAccount.bankAccounts
    }
  },
  async created () {
    try {
      await this.$store.dispatch('bankAccount/fetchAll')
    } catch (e) {
      this.$q.notify({
        type: 'negative',
        message: e.response.data
      })
    }
  }
}
</script>
